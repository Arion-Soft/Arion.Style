# Arion style

[![nuget](https://img.shields.io/nuget/v/Arion.Style)](https://www.nuget.org/packages/Arion.Style)
[![nuget(download)](https://img.shields.io/nuget/dt/Arion.Style)](https://www.nuget.org/packages/Arion.Style)

## Библиотека стилей

___

## Подключение

В менеджере пакетов Nuget находите пакет `Arion.Style` и устанавливаете его

![Arion.Style в менеджере пакетов nuget](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Arion.Style.png "Arion.Style в менеджере пакетов nuget")

В документ ```App.xaml``` добавляете словарь

```xaml
<ResourceDictionary>
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/Arion.Style;component/ArionUiTheme.xaml" />
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
Использование конкретных элементов прописано в самом элементе
___

### Оглавление

1. [Button](#Button)
2. [TextBox](#TextBox)
3. PasswordBox
4. [CheckBox](#CheckBox)
5. [ToggleButton](#ToggleButton)
6. [RadionButton](#RadioButton)
7. [Switcher](#Switcher)
8. [Slider](#Slider)
9. [ListView](#ListView)
10. [Tab](#Tab)
11. [Tooltip](#Tooltip)
12. [Colors](#Colors)
13. Таблицы
14. ProgressBar
15. Breadcrumb
16. ComboBox
17. DisplayControl
18. Expander
19. InlineAlert
20. Label
21. RangeSlider

___

### Button

#### Обычные кнопки

Есть несколько типов стилей кнопок `Filled`, `Outline`, `Text`

Filled - Закрашенные без рамок
Outline - Белые кнопки с рамками
Text - Белые кнопки без рамок, на белом фоне похожи на простой текст, пока не наведешь

Для использования стилей пишете сначала тип кнопки, потом её размер в сокращенном варианте

Доступные стили для версии 0.3.0

|                     | Filled                                                                                                                                                                    | Outline                                                                                                                                                                     | Text                                                                                                                                                                |
|---------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Standard            | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/Button.png)     | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/Button.png)     | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Button/Text/Button.png)     |
| Left icon           | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/LeftIcon.png)   | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/LeftIcon.png)   | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Button/Text/LeftIcon.png)   |
| Right icon          | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/RightIcon.png)  | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/RightIcon.png)  | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Button/Text/RightIcon.png)  |
| Center icon         | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/Icon.png)       | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/Icon.png)       | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Button/Text/Button.png)     |
| Linear progress bar | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/LinearLoad.png) | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/LinearLoad.png) | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Button/Text/LinearIcon.png) |
| Circle progress bar | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/CircleLoad.png) | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/CircleLoad.png) | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Button/Text/CircleLoad.png) |

`BtnFilled`,
`BtnOutline`,
`BtnText`,

___

### TextBox

Стиль текстового поля задан по умолчанию, поэтому какой то определенный стиль применять не требуется.

![Элемент TextBox](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/TextBox.png)

Так же есть текстовое поле с элементом предварительного текста `TextInput`.
В этом элементе можно указать свойство Placeholder, которое отобразит текст, который будет пропадать при вводе.

![Элемент TextInput](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/TextInput.png)
![Элемент TextInput с введеном текстом](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/TextInputWithText.png)

`xmlns:controls="clr-namespace:Arion.Theme.Controls;assembly=Arion.Theme"`

`<controls:TextInput Placeholder="Placeholder" />`

----

### PasswordBox

Стиль по умолчанию.
Так же есть дополнительное свойство `Placeholder`, для его использования добавьте в документ `XAML` ссылку на добавляемые свойства
```xaml
xmlns:attachedProperties="clr-namespace:Arion.Style.Theme.AttachedProperties;assembly=Arion.Style.Theme"
```

После чего для `PasswordBox` добавьте свойство `attachedProperties:PasswordBox.Placeholder=""`

----

### CheckBox

Стиль данного элемента также установлен по умолчанию, и имеет разное отображение на 3 состояния `Checked`, `Unchecked`, `Null`

![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/CheckBox.png)

----

### ToggleButton

ToggleButton имеет два стиля
1. По умолчанию


----

### RadioButton

Стиль установлен по умолчанию

----

### Switcher

Переключатели или же свитчеры, стиль для Радио кнопок.

Имеют 3 типа по отображению

|        | Switcher                                                                                                                                               |
|--------|--------------------------------------------------------------------------------------------------------------------------------------------------------|
| First  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/SwitcherFirst.png)       |
| Middle | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/SwitcherMiddle.png)     |
| Last   | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/SwitcherLast.png)         |

`SwitcherFirst`, `SwitcherMiddle`, `SwitcherLast`

----

### Slider

![Slider](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Slider.png)

----

### Tab

![Tabs](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Tabs.png)

----

### ListView


----

### Tooltip

Стиль по умолчанию

![ToolTip](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/ToolTip.png)

----

### Colors

|     | Pr                                                                                                                                               | R                                                                                                                                          | G                                                                                                                                            | Y                                                                                                                                             | P                                                                                                                                             | T                                                                                                                                           |
|-----|--------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------|
| 50  | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr50.png)       | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T50.png)   |
| 100 | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr100.png)     | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T100.png) |
| 200 | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr200.png)     | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T200.png) |
| 300 | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr300.png)     | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T300.png) |
| 400 | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr400.png)     | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T400.png) | 
| 500 | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr500.png)     | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T500.png) |
| 600 | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr600.png)     | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T600.png) |
| 700 | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr700.png)     | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T700.png) |
| 800 | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr800.png)     | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T800.png) |
| 900 | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Blue/Pr900.png)     | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Red/R900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Green/G900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Yellow/Y900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Purple/P900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Colors/Teal/T900.png) |

`Pr50`, `Pr100`, `Pr200`, `Pr300`, `Pr400`, `Pr500`, `Pr600`, `Pr700`, `Pr800`, `Pr900` и так далее

----

### Shadow

| El1                                                                                                                                 | El2                                                                                                                                 | El3                                                                                                                                 | El4                                                                                                                                 | El5                                                                                                                                 | El6                                                                                                                                 |
|-------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|
| ![El1](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Shadow/El1.png) | ![El2](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Shadow/El2.png) | ![El3](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Shadow/El3.png) | ![El4](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Shadow/El4.png) | ![El5](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Shadow/El5.png) | ![El6](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Theme.Images/Shadow/El6.png) |

---

### Контролеры

[Arion.Style.Controls](https://github.com/IDerkBot/Arion.Style/tree/master/Arion.Style.Controls)