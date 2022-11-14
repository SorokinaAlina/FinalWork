# Итоговая проверочная работа
## **Студент**: Сорокина Алина Андреевна
_____

### **Содержание вложения**:
* Описание задачи;
* Текстовое описание выбранного решения;
* Блок-схема алгоритма;
* Программа на языке C#;
* Результаты работы кода (скриншоты).

____

### **Описание задачи**

>Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3м символам. 
Первоначальный массив вводится с клавиатуры, либо задается на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

_____


### **Текстовое описание выбранного решения**

*Для решения задачи решила выбрать способ, когда пользователь может самостоятельно ввести слова/строки с клавиатуры и проверить работоспособность программы. Поэтому, заданный изначально массив был исключен из вариантов (удаление папки закоммичено).*

Каким именно способом решила: мы задаем массив, который вводит пользователь с клавиатуры, при этом перед непосредственным вводом пользователь должен указать количество слов, которые он будет вводить (чтобы мы задали массив нужной длины). После того, как мы получим первичный массив, мы задаем второй, в который записываем только те строки из первого, которые соответствуют условиям (а именно <= 3м символам). После этого выводим на экран пользователю все слова, которые он ввел, а также те слова, которые прошли проверку (для сравнения).
____

### Блок-схема алгоритма

Блок-схема приложена отдельным документом в папке с названием "Блок-схема алгоритма"

_____

### Программа на языке С#

Файл с программой расположен в папке variant1.
