using System.Windows;
using System.Windows.Controls;

namespace PageNavigationApp.Controls;

/// <summary>
/// Это классическая реализация кастомного (пользовательского) элемента управления в WPF. 
/// Вы создаете класс Btn, который наследуется от стандартного RadioButton, 
/// и переопределяете ключ стандартного стиля.
/// </summary>
public class Btn : RadioButton
{

    /// <summary>
    /// Переопределение DefaultStyleKeyProperty в статическом конструкторе сообщает системе WPF, 
    /// что этот элемент не должен использовать визуальный стиль родительского RadioButton. 
    /// Вместо этого движок WPF будет искать для него новый выделенный шаблон (ControlTemplate)
    /// </summary>
    static Btn()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
    }
}
