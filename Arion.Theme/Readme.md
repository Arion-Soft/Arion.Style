# Arion style

[![nuget](https://img.shields.io/nuget/v/Arion.Style)](https://www.nuget.org/packages/Arion.Style)

## Библиотека стилей

___

## Подключение

В менеджере пакетов Nuget находите пакет `Arion.Style` и устанавливаете его

![Arion.Style в менеджере пакетов nuget](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Arion.Style.png "Arion.Style в менеджере пакетов nuget")

В документ ```App.xaml``` добавляете словарь

```xaml
<ResourceDictionary>
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/Arion.Theme;component/ArionUiTheme.xaml" />
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
Использование конкретных элементов прописано в самом элементе
___

### Оглавление

1. [Кнопки](#Кнопка)
2. [Текстовые поля](#Текстовое-поле)
3. [Чек бокс](#Чек-бокс)
4. [Переключатель](#Переключатель)
5. [Радио кнопки](#Радио-кнопки)
6. [Свитчер](#Свитчер)
7. [Слайдер](#Слайдер)
8. [Списки](#Списки)
9. [Табы](#Табы)
10. [Всплывающие подсказки](#Всплывающие-подсказки)
11. [Цвета](#Цвета)
12. [Иконки](#Иконки)

___

### Кнопка

#### Обычные кнопки

Есть несколько типов стилей кнопок `Filled`, `Outline`, `Text`

Filled - Закрашенные без рамок
Outline - Белые кнопки с рамками
Text - Белые кнопки без рамок, на белом фоне похожи на простой текст, пока не наведешь

Так же есть 3 размера этих кнопок Large(`Lg`), Medium(`Md`) и Small(`Sm`)

Для использования стилей пишете сначала тип кнопки, потом её размер в сокращенном варианте

Доступные стили для версии 0.1.3

|             | Filled                                                                                                                      | Outline                                                                                                                       | Text                                                                                                                    |
|-------------|-----------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| Large (Lg)  | ![Кнопка со стилем FilledLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/FilledLg.png) | ![Кнопка со стилем OutlineLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/OutlineLg.png) | ![Кнопка со стилем TextLg](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/TextLg.png) |
| Medium (Md) | ![Кнопка со стилем FilledMd](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/FilledMd.png) | ![Кнопка со стилем OutlineMd](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/OutlineMd.png) | ![Кнопка со стилем TextMd](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/TextMd.png) |
| Small (Sm)  | ![Кнопка со стилем FilledSm](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/FilledSm.png) | ![Кнопка со стилем OutlineMd](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/OutlineSm.png) | ![Кнопка со стилем TextSm](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/TextSm.png) |

`FilledLg`,
`FilledMd`, 
`FilledSm`,
`OutlineLg`,
`OutlineMd`,
`OutlineSm`,
`TextLg`,
`TextMd`,
`TextSm`.

___

### Текстовое поле

Стиль текстового поля задан по умолчанию, поэтому какой то определенный стиль применять не требуется.

![Элемент TextBox](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/TextBox.png)

Так же есть текстовое поле с элементом предварительного текста `TextInput`.
В этом элементе можно указать свойство Placeholder, которое отобразит текст, который будет пропадать при вводе.

![Элемент TextInput](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/TextInput.png)
![Элемент TextInput с введеном текстом](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/TextInputWithText.png)

`xmlns:controls="clr-namespace:Arion.Theme.Controls;assembly=Arion.Theme"`

`<controls:TextInput Placeholder="Placeholder" />`

---

### Чек бокс

Стиль данного элемента также установлен по умолчанию, и имеет разное отображение на 3 состояния `Checked`, `Unchecked`, `Null`

![Чек бокс](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/CheckBox.png)

---

### Переключатель



---

### Радио кнопки

Стиль установлен по умолчанию

---

### Свитчер

Переключатели или же свитчеры, стиль для Радио кнопок.

Имеют 3 типа по отображению

|        | Switcher                                                                                                               |
|--------|------------------------------------------------------------------------------------------------------------------------|
| First  | ![SwitcherFirst](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/SwitcherFirst.png)   |
| Middle | ![SwitcherMiddle](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/SwitcherMiddle.png) |
| Last   | ![SwitcherLast](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/SwitcherLast.png)     |

`SwitcherFirst`, `SwitcherMiddle`, `SwitcherLast`

---

### Слайдер

![Slider](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Slider.png)

---

### Табы

![Tabs](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Tabs.png)

---

### Списки


---

### Всплывающие подсказки

![ToolTip](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/ToolTip.png)

---

### Цвета

|     | Pr                                                                                                                | R                                                                                                              | G                                                                                                                | Y                                                                                                                 | P                                                                                                                 | T                                                                                                               |
|-----|-------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------|
| 50  | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr50.png)    | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P50.png)   | ![Pr50](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T50.png)   |
| 100 | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr100.png)  | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P100.png) | ![Pr100](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T100.png) |
| 200 | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr200.png)  | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P200.png) | ![Pr200](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T200.png) |
| 300 | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr300.png)  | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P300.png) | ![Pr300](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T300.png) |
| 400 | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr400.png)  | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P400.png) | ![Pr400](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T400.png) | 
| 500 | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr500.png)  | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P500.png) | ![Pr500](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T500.png) |
| 600 | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr600.png)  | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P600.png) | ![Pr600](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T600.png) |
| 700 | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr700.png)  | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P700.png) | ![Pr700](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T700.png) |
| 800 | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr800.png)  | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P800.png) | ![Pr800](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T800.png) |
| 900 | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Blue/Pr900.png)  | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Red/R900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Green/G900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Yellow/Y900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Purple/P900.png) | ![Pr900](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Colors/Teal/T900.png) |

`Pr50`, `Pr100`, `Pr200`, `Pr300`, `Pr400`, `Pr500`, `Pr600`, `Pr700`, `Pr800`, `Pr900` и так далее

---

### Тени

| El1                                                                                                     | El2                                                                                                     | El3                                                                                                     | El4                                                                                                     | El5                                                                                                     | El6                                                                                                     |
|---------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|
| ![El1](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Shadow/El1.png) | ![El2](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Shadow/El2.png) | ![El3](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Shadow/El3.png) | ![El4](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Shadow/El4.png) | ![El5](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Shadow/El5.png) | ![El6](https://raw.githubusercontent.com/IDerkBot/Arion.Style/master/Arion.Theme/Images/Shadow/El6.png) |

---

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