using FluentValidation;
using System;

namespace Notes.Application.Notes.Commands.UpdateNotePatch
{
    public class UpdateNpteCommandValidator : AbstractValidator<UpdateNotePatchCommand>
    {
        public UpdateNpteCommandValidator()
        {
            RuleFor(updateNoteCommand => updateNoteCommand.Id).NotEqual(Guid.Empty);
            RuleFor(updateNoteCommand => updateNoteCommand.UserId).NotEqual(Guid.Empty);
            //RuleFor(updateNoteCommand => updateNoteCommand.Name).NotEmpty().MaximumLength(250);
        }
    }
}
