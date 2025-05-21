using System;
using Egeroro.Entity.Concrete;
using FluentValidation;

namespace Egeroro.Business.Validation
{
	public class ContactValidator : AbstractValidator<Contact>
    {
		public ContactValidator()
		{
		}
	}
}

