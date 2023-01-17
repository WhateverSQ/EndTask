# ControlTask
Итоговая проверочная работа

Объявляю два массива. **FirstArray** - массив с заданным содержанием. **SecondArray** - массив, в который буду добавлять элементы, которые меньше либо равны 3-м символам. 

Далее создаю метод **PrintArray**, который будет выводить в терминал массивы.

Затем создаю войд метод **FillSecondArray**, который принимает первый и второй массив.
В методе инициализирую переменную **count** - счетчик, который поможет поочередно заполнять **SecondArray** необходимыми элементами. Далее идет цикл for чтобы проверить все элементы массива. В этом цикле сделал условие, которое проверяет <= 3 элемент и, если он подходит под условие, то этот элемент записывается в **SecondArray**, после чего счетчик **count** увеличивается на 1. Это нужно чтобы в следующий раз записать новый элемент на новую позицию. 

Потом идет вывод в терминал строки "Start array: " и вызов метода **PrintArray** к **FirstArray** чтобы вывести изначальный массив.
Затем вызов метода **FillSecondArray** для заполнения второго массива необходимыми элементами.
После этого вывод в терминал строки "Final array: " и вызов метода **PrintArray** к **SecondArray** для вывода получившегося массива с элементами, количество символов в которых меньше либо равно 3.

*Основной метод в виде блок-схемы*


![Image](https://i.ibb.co/t4g8k0K/Image.png)
