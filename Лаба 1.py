end_buff, buff, help_buff, comma, tochka = [], [], [], ',', '.'        #Конечный буффер подходящих, изменённых чисел; Рабочий буффер; Переменная для проверки условия
filtr = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ',', '.']
with open('Numbers.txt') as f:
    while True:
        a = f.read(1)
        if a!=' ' and a!='' and a!='\n':                #Отделяем числа друг от друга
            buff.append(a)                              #И добавляем подходящие в рабочий буффер
        else:
            if (comma in buff) and (tochka in buff):
                buff.clear()
            elif (comma in buff) or (tochka in buff):   #Проверяем вещественное ли число в рабочем буффере
                for i in buff:                          #Заменяем запятую на точку
                    if i in filtr:                      #Проверяем, что символ является цифрой, запятой или точкой
                        if i == ',' or i == '.':
                            i = '.'
                            help_buff.append(i)
                            if help_buff == ['.']:
                                help_buff.clear()       # Заполняем конечный буффер
                            else:
                                end_buff.append()
                    else:
                        help_buff.clear()
                end_buff.append(' ')                    #Добавляем пробелы между числами
            buff.clear()
        if a == '':
            break
    end_buff[-1]=''                                     #Избавляемся от лишнего пробела в конце
print(''.join(end_buff))