using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using WodClock.Api.Constraints;

namespace WodClock.Api.Attributes
{
    public class RequiredFromQueryAttribute : FromQueryAttribute, IParameterModelConvention
    {
        public void Apply(ParameterModel parameter)
        {
            var selectors = parameter.Action.Selectors;

            if (selectors != null && parameter.Action.Selectors.Any())
            {
                selectors.Last().ActionConstraints.Add(
                    new RequiredFromQueryActionConstraint(
                        parameter.BindingInfo?.BinderModelName ?? parameter.ParameterName));
            };
        }
    }
}