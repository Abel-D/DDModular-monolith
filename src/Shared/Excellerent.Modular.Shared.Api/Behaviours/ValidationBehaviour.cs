using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using Excellerent.Modular.Shared.Application;

namespace Excellerent.Modular.Shared.Api.Behaviours
{
    internal sealed class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest
        where TResponse : IErrorOr
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public ValidationBehaviour()
        {

        }

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators == null)
            {
                return await next();
            }
            var context = new ValidationContext<TRequest>(request);

            var validationResult = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, CancellationToken.None)));
            List<dynamic> errs = new List<dynamic>();
            foreach (var validation in validationResult)
            {
                var err = validation.Errors.ConvertAll(v => Error.Validation(v.PropertyName, v.ErrorMessage));
                errs.Add(err);
            }
            // var err = validationResult.Errors.ConvertAll(error => Error.Validation(error.PropertyName, error.ErrorMessage));
            return Response<ValidationResult>.IsError(errs);
           }
    }
}
