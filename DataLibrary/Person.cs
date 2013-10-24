using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DataLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PostCreateModelValidator : AbstractValidator<Person>
    {
        public PostCreateModelValidator()
        {
            RuleFor(model => model.FirstName).NotEmpty().WithMessage("Enter a first name");
            RuleFor(model => model.LastName).NotEmpty().WithMessage("Enter a last name");
        }
    }
}
