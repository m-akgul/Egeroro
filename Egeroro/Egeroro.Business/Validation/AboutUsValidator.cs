using System;
using Egeroro.Entity.Concrete;
using FluentValidation;

namespace Egeroro.Business.Validation
{
	public class AboutUsValidator : AbstractValidator<AboutUs>
	{
		public AboutUsValidator()
		{
			RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez!");
			RuleFor(x => x.Description1).MinimumLength(20).WithMessage("Açıklamaya en az 20 karakter girilmeli!");
			RuleFor(x => x.Description1).MaximumLength(500).WithMessage("Açıklamaya en fazla 500 karakter girilebilir!");

			RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez!");
            RuleFor(x => x.Description2).MinimumLength(20).WithMessage("Açıklamaya en az 20 karakter girilmeli!");
            RuleFor(x => x.Description2).MaximumLength(500).WithMessage("Açıklamaya en fazla 500 karakter girilebilir!");
        }
	}
}

