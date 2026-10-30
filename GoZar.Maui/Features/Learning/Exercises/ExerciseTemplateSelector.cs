namespace GoZar.Maui.Features.Learning.Exercises;

public sealed class ExerciseTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        // TODO : Map the agreed server exercise discriminator to the corresponding registered view template.
        return new DataTemplate(() => new Label { Text = "نوع تمرین هنوز به قرارداد API متصل نشده است." });
    }
}
