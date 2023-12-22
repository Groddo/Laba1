# Лабораторная работа №2 #Написать программу, которая читая файл, распознает, преобразует и выводит на экран числа по определенному правилу.
# Числа распознаются по законам грамматики русского языка.
# Преобразование делать по возможности через словарь.
# Для упрощения под выводом числа прописью подразумевается последовательный вывод всех цифр числа.
# Распознование делать через регулярные выражения. В вариантах, где есть параметр К, К заменяется на любое число.

#Вариант 3. #Вещественные числа. В них менять запятую на точку.

## Не учитывает если запятая стоит перед числом, а также, если число отрицательное, то не выводит минус


import re
with open('Numbers.txt') as file:
    while True:
        a = file.readline()
        if not a:
            break
        res = re.findall(r"[0-9]+[,.][0-9]*[^.,]", a)
        if len(res) >= 1:
            for j in res:
                print(j.replace(',','.'), end= ' ')
