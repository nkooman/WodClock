using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace WodClock.Api.Constraints
{
    public class RequiredFromQueryActionConstraint : IActionConstraint
    {
        private readonly string parameter;
        public RequiredFromQueryActionConstraint(string parameter)
        {
            this.parameter = parameter;
        }

        public int Order => 999;

        public bool Accept(ActionConstraintContext context)
            => context.RouteContext.HttpContext.Request.Query.ContainsKey(parameter);

    }
}