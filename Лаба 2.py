import re
with open('Numbers.txt') as file:
    while True:
        a = file.readline()
        res = re.findall(r'[0-9]*\,[0-9]', a)
        if len(res) >= 1:
            for j in res:
                print(j.replace(',','.'))
        if not a:
            break