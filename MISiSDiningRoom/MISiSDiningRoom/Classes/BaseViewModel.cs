using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MISiSDiningRoom.Classes
{
    internal class BaseViewModel : INotifyPropertyChanged

        /*INotifyPropertyChanged При выполнении этого примера вы заметите,
         * что связанный DataGridView элемент управления отражает изменения
         * в источнике данных без необходимости сбрасывать привязку.*/
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /*PropertyChangedEventHandler Представляет метод, который обрабатывает событие PropertyChanged,
         * возникающее при изменении свойства компонента. */

        public void OnPropertyChanged([CallerMemberName] string name = "")
        /*Для реализации INotifyPropertyChanged 
         * вам необходимо объявить событие PropertyChanged и создать OnPropertyChangedметод.
         * Затем для каждого свойства, для которого вы хотите получать уведомления об изменениях,
         * вы вызываете OnPropertyChangedего всякий раз, когда свойство обновляется.*/

        /*Вы можете использовать CallerMemberName атрибут,
         * чтобы не указывать имя члена в качестве String аргумента вызываемого метода.
         * Используя этот метод, вы избегаете проблемы, заключающейся в том,
         * что рефакторинг переименования не изменяет String значения.
         * Это преимущество особенно полезно для следующих задач:
         * Реализация интерфейса INotifyPropertyChanged при привязке данных.
         * Этот интерфейс позволяет свойству объекта уведомлять связанный элемент управления об изменении свойства.
         * Элемент управления может отображать обновленную информацию. 
         * Без CallerMemberName атрибута необходимо указать имя свойства как литерал.*/

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
