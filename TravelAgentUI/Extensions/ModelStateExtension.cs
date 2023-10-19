using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace TravelAgentUI.Extensions
{
    public static class ModelStateExtension
    {
        public static void AddErrorModelList(this ModelStateDictionary modelState,List<string> errors )
        {
            errors.ForEach(x =>
            {
                modelState.AddModelError(string.Empty, x);
            });
        }
    }
}
