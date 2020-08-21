using System;
using Microsoft.AspNetCore.Mvc;
using login_register.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using exam1_csharp.Models;


namespace exam1_csharp.Controllers
{
    public class PlannerController : Controller
    {

        private MyContext _context;

        public PlannerController(MyContext context){
            _context = context;
        }

        //Global variables
        


        [HttpGet("/home")]
        public IActionResult PlannerCenter()
        {
            var UserId = HttpContext.Session.GetString("UserId");
            if(UserId!=null)
            {
                PlannerVmod vmod = new PlannerVmod{
                    Parties = _context.Parties
                        .Include(p => p.Owner)
                        .Include(p => p.RSVPs)
                        .ThenInclude(r => r.User).OrderBy(p => p.Date)
                        .Where(p => p.Date > DateTime.Now)
                        .ToList(),
                    User = _context.Users.FirstOrDefault(u=>u.UserId.ToString() == UserId)
                };
                return View("PlannerCenter", vmod);
            }
            return Redirect("/");
        }

        [HttpGet("/new")]
        public IActionResult NewParty()
        {
            var UserId = HttpContext.Session.GetString("UserId");
            if(UserId!=null)
            {
                Party party = new Party{
                    OwnerId = Int32.Parse(UserId),
                    Owner = _context.Users.FirstOrDefault(u => u.UserId.ToString() == UserId)
                };
                return View("NewParty", party);
            }
            return Redirect("/");
        }

        [HttpPost("create_activity")]
        public IActionResult CreateParty(Party party)
        {
            var UserId = HttpContext.Session.GetString("UserId");
            if(UserId!=null)
            {
                if(ModelState.IsValid){
                    party.Date = party.Date + party.Time.TimeOfDay;
                    _context.Add(party);
                    _context.SaveChanges();
// ------------- change to view activity not home
                    // return Redirect("activity/1");
                    return RedirectToAction("ViewParty",new {partyId= party.PartyId });
                }
                return View("NewParty", party);
            }
            return Redirect("/");
        }

        [HttpGet("activity/{partyId}")]
        public IActionResult ViewParty(int partyId)
        {
            var UserId = HttpContext.Session.GetString("UserId");
            if(UserId!=null)
            {
                ViewBag.user_name = _context.Users.FirstOrDefault(u => u.UserId.ToString() == UserId).Name;
                ViewBag.userId = Int32.Parse(UserId);
                Party party = _context.Parties
                    .Include(p => p.Owner)
                    .Include(p => p.RSVPs)
                    .ThenInclude(r => r.User)
                    .FirstOrDefault(p => p.PartyId == partyId);
                return View("ViewParty", party);
            }
            return Redirect("/");
        }

        [HttpGet("change_rsvp/{partyId}/{position}")]
        public IActionResult ChangeRSVP(int partyId, int position)
        {
            var UserId = HttpContext.Session.GetString("UserId");
            if(UserId!=null)
            {
                //get user
                User user = _context.Users
                    .Include(u => u.RSVPs)
                    .ThenInclude(u => u.Party)
                    .FirstOrDefault(u => u.UserId.ToString() == UserId);
                //if user attending then remove rsvp
                if(user.RSVPs.Any(r => r.PartyId == partyId)){
                    RSVP rsvp = _context.RSVPs
                        .FirstOrDefault(r => r.PartyId == partyId && r.UserId.ToString() == UserId);
                    _context.Remove(rsvp);
                    _context.SaveChanges();
                }
                else{
                    RSVP rsvp = new RSVP{
                        UserId = user.UserId,
                        PartyId = partyId
                    };
                    _context.Add(rsvp);
                    _context.SaveChanges();
                }
                if(position == 1){
                    return RedirectToAction("ViewParty",new {partyId= partyId });
                }
                else{
                    return RedirectToAction("PlannerCenter");
                }

            }
            return Redirect("/");
        }

        [HttpGet("delete/{partyId}")]
        public IActionResult DeleteParty(int partyId)
        {
            var UserId = HttpContext.Session.GetString("UserId");
            if(UserId!=null)
            {
                Party party = _context.Parties.FirstOrDefault(p => p.PartyId == partyId);
                if(party.OwnerId.ToString() == UserId){
                    _context.Remove(party);
                    _context.SaveChanges();
                }
                return RedirectToAction("PlannerCenter");
            }
            return Redirect("/");
        }
    }
}
