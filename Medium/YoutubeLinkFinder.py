url = input()
try:
    print(url.split('=')[1])
except:
    stel = url.split('/')
    print(stel[len(stel)-1])
