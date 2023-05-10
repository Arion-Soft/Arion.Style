# Arion style
#### Библиотека стилей
[![nuget](https://img.shields.io/nuget/v/Arion.Style)](https://www.nuget.org/packages/Arion.Style)
[![nuget(download)](https://img.shields.io/nuget/dt/Arion.Style)](https://www.nuget.org/packages/Arion.Style)


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
3. [PasswordBox](#PasswordBox)
4. [CheckBox](#CheckBox)
5. [ToggleButton](#ToggleButton)
6. [RadioButton](#RadioButton)
7. [Switcher](#Switcher)
8. [Slider](#Slider)
9. [ListView](#ListView)
10. [Tab](#Tab)
11. [Tooltip](#Tooltip)
12. [Colors](#Colors)
13. [Tables](#Tables)
14. [ProgressBar](#ProgressBar)
15. [Breadcrumb](#Breadcrumb)
16. [ComboBox](#ComboBox)
17. [DisplayControl](#DisplayControl)
18. [Expander](#expander)
19. [InlineAlert](#InlineAlert)
20. [Label](#Label)
21. [RangeSlider](#RangeSlider)
22. [Shadow](#Shadow)

---

### Button

Есть несколько типов стилей кнопок `Filled`, `Outline`, `Text`

Filled - Закрашенные без рамок
Outline - Белые кнопки с рамками
Text - Белые кнопки без рамок, на белом фоне похожи на простой текст, пока не наведешь

Для использования стилей пишете тип кнопки

Доступные стили для версии 0.3.0

| Default             | Filled                                                                                                                                                                    | Outline                                                                                                                                                                     | Text                                                                                                                                                          |
|---------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Standard            | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/Button.png)     | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/Button.png)     | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Text/Button.png)     |
| Left icon           | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/LeftIcon.png)   | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/LeftIcon.png)   | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Text/LeftIcon.png)   |
| Right icon          | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/RightIcon.png)  | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/RightIcon.png)  | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Text/RightIcon.png)  |
| Center icon         | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/Icon.png)       | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/Icon.png)       | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Text/Icon.png)       |
| Linear progress bar | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/LinearLoad.png) | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/LinearLoad.png) | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Text/LinearLoad.png) |
| Circle progress bar | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Filled/Default/CircleLoad.png) | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Outline/Default/CircleLoad.png) | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Button/Text/CircleLoad.png) |

`BtnFilled`,
`BtnOutline`,
`BtnText`,

___

### TextBox

Стиль текстового поля задан по умолчанию, поэтому какой то определенный стиль применять не требуется.

![Элемент TextBox](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/TextBox/Default.png)



----

### PasswordBox



----

### CheckBox

Стиль данного элемента также установлен по умолчанию, и имеет разное отображение на 3 состояния `Checked`, `Unchecked`, `Null`

![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/CheckBox/Default.png)
![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/CheckBox/Checked.png)
![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/CheckBox/Mixed.png)

----

### ToggleButton

ToggleButton имеет два стиля
1. По умолчанию

![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/ToggleButton/Default.png)
![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/ToggleButton/Checked.png)
![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/ToggleButton/Mixed.png)


----

### RadioButton

Стиль установлен по умолчанию
![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/RadioButton/Default.png)
![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/RadioButton/Selected.png)


----

### Switcher

Переключатели или же свитчеры, стиль для Радио кнопок.

Имеют 3 типа по отображению

| Default | First                                                                                                                                                               | Middle                                                                                                                                                                | Last                                                                                                                                                              |
|---------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Filled  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Default/First/Default.png)  | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Default/Middle/Default.png)  | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Default/Last/Default.png)  |
| Outline | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Default/First/Default.png) | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Default/Middle/Default.png) | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Default/Last/Default.png) |

| Hover   | First                                                                                                                                                             | Middle                                                                                                                                                              | Last                                                                                                                                                            |
|---------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Filled  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Hover/First/Default.png)  | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Hover/Middle/Default.png)  | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Hover/Last/Default.png)  |
| Outline | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Hover/First/Default.png) | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Hover/Middle/Default.png) | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Hover/Last/Default.png) |

| Disabled | First                                                                                                                                                                | Middle                                                                                                                                                                 | Last                                                                                                                                                               |
|----------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Filled   | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Disabled/First/Default.png)  | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Disabled/Middle/Default.png)  | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Disabled/Last/Default.png)  |
| Outline  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Disabled/First/Default.png) | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Disabled/Middle/Default.png) | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Disabled/Last/Default.png) |

| Focus   | First                                                                                                                                                             | Middle                                                                                                                                                              | Last                                                                                                                                                            |
|---------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Filled  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Focus/First/Default.png)  | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Focus/Middle/Default.png)  | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Focus/Last/Default.png)  |
| Outline | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Focus/First/Default.png) | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Focus/Middle/Default.png) | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Focus/Last/Default.png) |

| Selected | First                                                                                                                                                                | Middle                                                                                                                                                                 | Last                                                                                                                                                               |
|----------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Filled   | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Selected/First/Default.png)  | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Selected/Middle/Default.png)  | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Filled/Selected/Last/Default.png)  |
| Outline  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Selected/First/Default.png) | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Selected/Middle/Default.png) | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Switcher/Outline/Selected/Last/Default.png) |

`SwitcherFirst`, `SwitcherMiddle`, `SwitcherLast`

----

### Slider

![Slider](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Slider/Default.png)

----

### ListView


----

### Tab

![Tabs](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Tab/HorizontalTab.png)

----

### Tooltip

Стиль по умолчанию

![ToolTip](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Tooltip/Default.png)

----

### Colors

|     | Pr                                                                                                                                     | R                                                                                                                                    | G                                                                                                                                      | Y                                                                                                                                       | P                                                                                                                                       | T                                                                                                                                     |
|-----|----------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------|
| 50  | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T50.png)   |
| 100 | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T100.png) |
| 200 | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T200.png) |
| 300 | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T300.png) |
| 400 | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T400.png) | 
| 500 | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T500.png) |
| 600 | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T600.png) |
| 700 | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T700.png) |
| 800 | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T800.png) |
| 900 | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Blue/Pr900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Red/R900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Green/G900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Yellow/Y900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Purple/P900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Colors/Teal/T900.png) |

`Pr50`, `Pr100`, `Pr200`, `Pr300`, `Pr400`, `Pr500`, `Pr600`, `Pr700`, `Pr800`, `Pr900` и так далее

----

### Shadow

| El1                                                                                                                           | El2                                                                                                                           | El3                                                                                                                           | El4                                                                                                                           | El5                                                                                                                           | El6                                                                                                                           |
|-------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| ![El1](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Shadow/El1.png) | ![El2](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Shadow/El2.png) | ![El3](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Shadow/El3.png) | ![El4](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Shadow/El4.png) | ![El5](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Shadow/El5.png) | ![El6](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/FilesForReadme/Files/Artion.Style.Images/Shadow/El6.png) |

---

### Tables

---

### ProgressBar

---

### Breadcrumb

---

### ComboBox

---

### DisplayControl

---

### Expander

---

### InlineAlert

---

### Label

---

### RangeSlider

---