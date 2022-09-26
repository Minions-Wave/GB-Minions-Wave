# Заголовки H1
## Заголовок H2
### Заголовок H3
#### Заголовок H4
##### Заголовок H5
###### Заголовок H6

## Код
Поскольку GFM создавался для программистов, в нём есть специальное форматирование для
кусков кода. Код выделяется символом `, то есть грависом. Окружив слово или фразу
грависами, можно создавать строчки кода:

`Какой-то очень важный код.`

А три грависа позволяют отметить целый блок кода. Ещё это полезно, чтобы выделить целый
абзац.

```
Целый абзац очень важного кода.
И ещё строка.
И ещё.
```

## Выделение курсивом и полужирным

*Курсив* и _Курсив_

**Жирный текст** и __Жирный текст__

***Жирный и курсивный текст***

## Цитирование
> Очень глубокомысленная цитата. Пожалуйста, прочтите её внимательно.
>
> Оскар Уайльд

##Нумерованные и маркированные списки
- Первый пункт.
- Второй пункт.
- Третий пункт.

1. Первый пункт.
2. Второй пункт.
3. Третий пункт.

## Смешанные списки

1. Первый пункт.
- Первый подпункт.
- Второй подпункт.
- Третий подпункт.
2. Второй пункт.
- Первый подпункт.
- Второй подпункт.
- Третий подпункт.

## Горизонтальные линии
Просто введите три раза (или больше) один из этих символов
***
---
___

## Ссылки и изображения
[Лайфхакер](lifehacker.ru)

Поставьте восклицательный знак, подпись к изображению в квадратных скобках и ссылку
на него в круглых скобках. Можно указывать ссылки на картинки как из интернета, так
и на хранящиеся на жёстком диске. Подпись указывать необязательно. Выглядит это 
следующим образом:

![подпись](F:\Pics\хрю.png) 

---
с локального диска чот не подгружается(((

---


![подпись](https://img-fotki.yandex.ru/0_1e4c1e_cd5df3e5_orig.jpg) 

а с инета - норм

## Эскапированные символы
Иногда вам нужно вставить в документ какой-нибудь символ, который относится к синтаксису
Markdown. Вы печатаете его, и форматирование меняется, хоть вам это и не нужно. В таком
случае перед техническими символами нужно ставить обратный слэш — \.

## Расширенный синтаксис
Чуть более сложные элементы оформления текстов, которые можно использовать в редакторах,
поддерживающих GFM (GitHub Flavored Markdown). GFM — расширенная версия обычного Markdown.
Тут есть таблицы, смайлы, зачёркнутый текст и прочие мелочи. GFM используется в
большинстве редакторов.

### Зачёркнутый текст
Расширенный синтаксис Markdown GFM позволяет зачёркивать текст, заключая его в двойные
тильды ~~.

~~Зачёркнутый текст.~~

### Таблицы
Если ваш редактор поддерживает GFM, то в нём можно создавать простенькие таблицы. Для
таблиц используйте символы | и -. Примерно так:

| раз | два | три |
|:----|:----|:----|
| раз | два | три |

### Списки дел
В Markdown есть даже своеобразные списки задач — аналог чекбоксов в OneNote или Evernote.
Вот как они выглядят:

- [ ] Невыполненная задача
- [ ] Невыполненная задача
- [X] Выполненная задача

### Эмодзи
В GFM есть ещё несколько мелочей, которые могут пригодиться вам при форматировании текста.
Например, эмодзи. Чтобы добавить смайл, нужно напечатать соответствующий код и заключить
его в двоеточия:

:kissing_heart:

Посмотреть коды эмодзи можно [здесь](https://www.webpagefx.com/tools/emoji-cheat-sheet/)