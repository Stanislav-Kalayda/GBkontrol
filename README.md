# Итоговая контрольная работа по основному блоку

## Описание контрольной работы

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

**Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:**

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

> Примеры:
> [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] > [“1234”, “1567”, “-2”, “computer science”] → [“-2”] > [“Russia”, “Denmark”, “Kazan”] → []

# Описание работы программы

**Вводные данные**

1. Массив **arraySum** - это массив с заданными значениями.
2. Массив **arrayResult** - это изначально пустой массив, служит для хранения конечного результата.

**Ход решения**

> Создаем функцию **arrayFill** в локальной зоне видимости этой функции создаем переменную **temp - счётчик для подходящий условий**, создаем цикл **for** - в котором происходит перебор каждого элемента в массиве, и при помощи условия **if(start[i].Length <=3)** определяется соотвествия заданному условию, если условия соблюдается, то элемент начального массива присваивается к элементу массива с индексом **temp**. Далее **temp** увеличивется на одну единицу.

> Создаем функцию для вывода массива **void arrayPrint** перебор массива осуществляем при помощи цикла **for**.

> В конце в переменную **arrayResult** присваиваем функцию **arrayFill(arraySum, arrayResult)**.
> И выводим наш массив при помощи вызова функции **arrayPrint(arrayResult)**.

## Создал блок - схему
![diag drawio](https://github.com/Freaz57/GBkontrol/assets/128412186/a0430a5a-1cd9-4468-a1bf-40785184c73d)
