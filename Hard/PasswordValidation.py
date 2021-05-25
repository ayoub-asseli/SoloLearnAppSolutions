password = list(input())
numbers = [x for x in password if x.isnumeric()]
symbols = [x for x in password if x in '!@#$%&*']
if len(password) < 7 or len(numbers) < 2 or len(symbols) < 2:
    print('Weak')
else:
    print('Strong')