# Final_task_of_block

## Общее описание программы:
Пользователь вводит количество элементов массива и сами элементы, и на консоли получает введенный им строковый массив и массив из элементов первого массива, длина которых меньше или равна 3.

**Ограничения:** 
1. Размер массива должен быть больше 0.
2. Пустая строка не считается как элемент введенного массива.

## Описание методов
### ShowArray

Принимает на вход одномерный массив типа string и выводит его на консоль, ставя после каждого элемента "," и обрамляя квадратными скобками весь массив.

Вход: *666666 ewrwrwrwr :;2*

Вывод на консоль: *[666666, ewrwrwrwr, :;2]*

### FindElemLenLessThree

Принимает на вход массив строкового типа и на выход дает новый массив строкового типа из элементов первого массива, длина которых меньше 3.

Вход: *666666 ewrwrwrwr :;2*

Выход: *:;2*

Сначала через цикличных проход по массиву вычисляется количество элементов, длина которых меньше либо равна 3. Если такие элементы есть, через цикл снова ищем эти элементы и записываем в новый массив. Если же их нет, то создаем пустой массив из одного элемента, чтобы после выполнения метода ShowArray на консоли было показано "[]"