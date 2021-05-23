n = int(input())
s = 0
for i in range(n):
    nb = int(input())
    if nb % 2 == 0:
        s += nb
print(s)