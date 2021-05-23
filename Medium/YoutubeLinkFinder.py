url = input()
try:
    print(url.split('=')[1])
except:
    stel = url.split('/')
    print(url.split('/')[len(stel)-1])