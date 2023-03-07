# Arion style

## Библиотека компонентов и стилей

___

## Подключение

В менеджере пакетов Nuget находите пакет `Arion.Style` и устанавливаете его

![Arion.Style в менеджере пакетов nuget](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Arion.Style.png?raw=true "Arion.Style в менеджере пакетов nuget")

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

|             | Filled                                                                                                                     | Outline                                                                                                                      | Text                                                                                                                   |
|-------------|----------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------|
| Large (Lg)  | ![Кнопка со стилем FilledLg](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/FilledLg.png?raw=true) | ![Кнопка со стилем OutlineLg](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/OutlineLg.png?raw=true) | ![Кнопка со стилем TextLg](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/TextLg.png?raw=true) |
| Medium (Md) | ![Кнопка со стилем FilledMd](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/FilledMd.png?raw=true) | ![Кнопка со стилем OutlineMd](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/OutlineMd.png?raw=true) | ![Кнопка со стилем TextMd](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/TextMd.png?raw=true) |
| Small (Sm)  | ![Кнопка со стилем FilledSm](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/FilledSm.png?raw=true) | ![Кнопка со стилем OutlineMd](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/OutlineSm.png?raw=true) | ![Кнопка со стилем TextSm](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/TextSm.png?raw=true) |

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

![Элемент TextBox](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/TextBox.png?raw=true)

Так же есть текстовое поле с элементом предварительного текста `TextInput`.
В этом элементе можно указать свойство Placeholder, которое отобразит текст, который будет пропадать при вводе.

![Элемент TextInput](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/TextInput.png?raw=true)
![Элемент TextInput с введеном текстом](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/TextInputWithText.png?raw=true)

`xmlns:controls="clr-namespace:Arion.Theme.Controls;assembly=Arion.Theme"`

`<controls:TextInput Placeholder="Placeholder" />`

---

### Чек бокс

Стиль данного элемента также установлен по умолчанию, и имеет разное отображение на 3 состояния `Checked`, `Unchecked`, `Null`

![Чек бокс](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/CheckBox.png?raw=true)

---

### Переключатель



---

### Радио кнопки

Стиль установлен по умолчанию

---

### Свитчер

Переключатели или же свитчеры, стиль для Радио кнопок.

Имеют 3 типа по отображению

|        | Switcher                                                                                                              |
|--------|-----------------------------------------------------------------------------------------------------------------------|
| First  | ![SwitcherFirst](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/SwitcherFirst.png?raw=true)   |
| Middle | ![SwitcherMiddle](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/SwitcherMiddle.png?raw=true) |
| Last   | ![SwitcherLast](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/SwitcherLast.png?raw=true)     |

`SwitcherFirst`, `SwitcherMiddle`, `SwitcherLast`

---

### Слайдер

![Slider](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Slider.png?raw=true)

---

### Табы

![Tabs](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Tabs.png?raw=true)

---

### Всплывающие подсказки

![ToolTip](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/ToolTip.png?raw=true)

---

### Цвета

|     | Pr                                                                                                               | R                                                                                                             | G                                                                                                               | Y                                                                                                                | P                                                                                                                | T                                                                                                              |
|-----|------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------|
| 50  | ![Pr50](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr50.png?raw=true)    | ![Pr50](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R50.png?raw=true)   | ![Pr50](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G50.png?raw=true)   | ![Pr50](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y50.png?raw=true)   | ![Pr50](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P50.png?raw=true)   | ![Pr50](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T50.png?raw=true)   |
| 100 | ![Pr100](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr100.png?raw=true)  | ![Pr100](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R100.png?raw=true) | ![Pr100](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G100.png?raw=true) | ![Pr100](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y100.png?raw=true) | ![Pr100](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P100.png?raw=true) | ![Pr100](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T100.png?raw=true) |
| 200 | ![Pr200](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr200.png?raw=true)  | ![Pr200](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R200.png?raw=true) | ![Pr200](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G200.png?raw=true) | ![Pr200](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y200.png?raw=true) | ![Pr200](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P200.png?raw=true) | ![Pr200](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T200.png?raw=true) |
| 300 | ![Pr300](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr300.png?raw=true)  | ![Pr300](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R300.png?raw=true) | ![Pr300](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G300.png?raw=true) | ![Pr300](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y300.png?raw=true) | ![Pr300](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P300.png?raw=true) | ![Pr300](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T300.png?raw=true) |
| 400 | ![Pr400](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr400.png?raw=true)  | ![Pr400](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R400.png?raw=true) | ![Pr400](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G400.png?raw=true) | ![Pr400](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y400.png?raw=true) | ![Pr400](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P400.png?raw=true) | ![Pr400](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T400.png?raw=true) | 
| 500 | ![Pr500](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr500.png?raw=true)  | ![Pr500](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R500.png?raw=true) | ![Pr500](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G500.png?raw=true) | ![Pr500](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y500.png?raw=true) | ![Pr500](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P500.png?raw=true) | ![Pr500](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T500.png?raw=true) |
| 600 | ![Pr600](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr600.png?raw=true)  | ![Pr600](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R600.png?raw=true) | ![Pr600](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G600.png?raw=true) | ![Pr600](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y600.png?raw=true) | ![Pr600](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P600.png?raw=true) | ![Pr600](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T600.png?raw=true) |
| 700 | ![Pr700](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr700.png?raw=true)  | ![Pr700](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R700.png?raw=true) | ![Pr700](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G700.png?raw=true) | ![Pr700](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y700.png?raw=true) | ![Pr700](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P700.png?raw=true) | ![Pr700](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T700.png?raw=true) |
| 800 | ![Pr800](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr800.png?raw=true)  | ![Pr800](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R800.png?raw=true) | ![Pr800](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G800.png?raw=true) | ![Pr800](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y800.png?raw=true) | ![Pr800](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P800.png?raw=true) | ![Pr800](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T800.png?raw=true) |
| 900 | ![Pr900](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Blue/Pr900.png?raw=true)  | ![Pr900](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Red/R900.png?raw=true) | ![Pr900](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Green/G900.png?raw=true) | ![Pr900](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Yellow/Y900.png?raw=true) | ![Pr900](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Purple/P900.png?raw=true) | ![Pr900](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Colors/Teal/T900.png?raw=true) |

`Pr50`, `Pr100`, `Pr200`, `Pr300`, `Pr400`, `Pr500`, `Pr600`, `Pr700`, `Pr800`, `Pr900` и так далее

---

### Тени

| El1                                                                                                    | El2                                                                                                    | El3                                                                                                    | El4                                                                                                    | El5                                                                                                    | El6                                                                                                    |
|--------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| ![El1](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Shadow/El1.png?raw=true) | ![El2](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Shadow/El2.png?raw=true) | ![El3](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Shadow/El3.png?raw=true) | ![El4](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Shadow/El4.png?raw=true) | ![El5](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Shadow/El5.png?raw=true) | ![El6](https://github.com/IDerkBot/Arion.Style/blob/master/Arion.Theme/Images/Shadow/El6.png?raw=true) |

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