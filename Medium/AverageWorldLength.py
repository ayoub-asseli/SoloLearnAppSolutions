from math import ceil
words = input().split()
s = 0
i = 0
for word in words:
    if word.isalpha():
        s += len(word)
        i += 1
    else:
        s += len(word)-1
        i += 1
print(ceil(s/i))