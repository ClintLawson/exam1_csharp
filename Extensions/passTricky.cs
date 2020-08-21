using System;
using System.ComponentModel.DataAnnotations;

public class PassTrickAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // You first may want to unbox "value" here and cast to to a DateTime variable!
        //get the current date and compare it 

        if(value==null){
            return new ValidationResult("Date cannot be empty");
        }
        string test = value.ToString();
        bool num = false;
        bool character = false;
        bool caps = false;
        for(var i = 0; i< value.ToString().Length; i++){
            if(test[i] >= 'A' && test[i] <= 'Z'){
                caps = true;
            }
            if(test[i] >= '0' && test[i] <= '9'){
                num = true;
            }
            if(test[i] >= '!' && test[i] <='~'){
                character = true;
            }
        }
        

        //compare the dat
        if(num == false || caps == false || character == false){
            return new ValidationResult("Password Must Contain a capital letter, number and special character");
        }

        return ValidationResult.Success;
    }
}
