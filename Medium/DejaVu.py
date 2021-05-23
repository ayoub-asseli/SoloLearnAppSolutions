string = input()
for i in range(len(string)):
    if string[i] in string[i+1:]:
        print('Deja Vu')
        exit()
    else:
        continue
print('Unique')