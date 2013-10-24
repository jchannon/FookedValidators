using DataLibrary;
using Nancy.ModelBinding;
using Nancy.Validation;

namespace FookedValidators
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Post["/"] = _ =>
                {
                    var person = this.BindAndValidate<Person>(); 

                    //Should be false if not entered information
                    return this.ModelValidationResult.IsValid;
                };
        }
    }

    
}