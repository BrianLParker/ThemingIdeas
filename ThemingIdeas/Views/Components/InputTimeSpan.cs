using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;

namespace ThemingIdeas.Views.Components
{
    public class InputTimeSpan : InputBase<TimeSpan>
    {
        private const string TimeSpanFormat = "hh\\:mm\\:ss";

        [Parameter] public string ParsingErrorMessage { get; set; } = "The {0} field must be a time.";

        [DisallowNull] public ElementReference? Element { get; protected set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "input");
            builder.AddMultipleAttributes(1, AdditionalAttributes);
            builder.AddAttribute(2, "type", "time");
            builder.AddAttribute(3, "step", "1");
            builder.AddAttribute(4, "class", CssClass);
            builder.AddAttribute(5, "value", BindConverter.FormatValue(CurrentValueAsString));
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
            builder.AddAttribute(6, "onchange", EventCallback.Factory.CreateBinder<string>(this, __value => CurrentValueAsString = __value, CurrentValueAsString));
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
            builder.AddElementReferenceCapture(6, __inputReference => Element = __inputReference);
            builder.CloseElement();
        }

        protected override string FormatValueAsString(TimeSpan value)
            => value.ToString(TimeSpanFormat, CultureInfo.InvariantCulture);

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        protected override bool TryParseValueFromString(string value, [MaybeNullWhen(false)] out TimeSpan result, [NotNullWhen(false)] out string validationErrorMessage)
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        {
            bool success = TimeSpan.TryParse(value, out result);

            if (success is true)
            {
                validationErrorMessage = null;
                return true;
            }
            else
            {
                validationErrorMessage = string.Format(CultureInfo.InvariantCulture, ParsingErrorMessage, DisplayName ?? FieldIdentifier.FieldName);
                return false;
            }
        }
    }
}
