# Arion Controls

[![nuget](https://img.shields.io/nuget/v/Arion.Style.Controls)](https://www.nuget.org/packages/Arion.Style.Controls)
[![nuget(download)](https://img.shields.io/nuget/dt/Arion.Style.Controls)](https://www.nuget.org/packages/Arion.Style.Controls)

## Библиотека компонентов

___

## Подключение

В менеджере пакетов Nuget находите пакет `Arion.Style.Controls` и устанавливаете его
![Arion.Style в менеджере пакетов nuget](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Arion.Style.Controls.Images/nuget.png "Arion.Style.Controls в менеджере пакетов nuget")

В документ в котором вам необходимо добавить элемент добавляете ссылку

```xaml
xmlns:arion="clr-namespace:Arion.Style.Controls;assembly=Arion.Style.Controls"
```
Использование конкретных элементов прописано в самом элементе
___

### Оглавление

1. [Иконки](#Иконки)
2. [Уведомление](#Уведомление)
3. [RangeSlider](#RangeSlider)
4. [Хлебные крошки](#Хлебные крошки)

___

### Иконки

Для того что бы использовать иконки требуется так же подключить директорию контролов из библиотеки

`xmlns:controls="clr-namespace:Arion.Theme.Controls;assembly=Arion.Theme"`

После чего появится возможность использовать элемент `Icon`

`<controls:Icon Kind="" Width="" Height="" Fill=""/>`

В данном элементе есть 4 стандартных свойства которые требуется задать
* `Kind` - Иконка
* `Width` - Ширина
* `Height` - Высота
* `Fill` - Заливка цветом

Пак всех иконок будет добавлен позднее

----

### Уведомление


### RangeSlider


### Хлебные крошки