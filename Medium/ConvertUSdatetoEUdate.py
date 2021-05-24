months = {
    'January': '1',
    'Febrary': '2',
    'March': '3',
    'April': '4',
    'May': '5',
    'June': '6',
    'July': '7',
    'August': '8',
    'September': '9',
    'October': '10',
    'November': '11',
    'December': '12'
}
date = input()
if '/' in date:
    date = date.split('/')
    day, month = date[1], date[0]
    date[0], date[1] = day, month
    print('/'.join(date))
else:
    date = date.split(',')
    new_date = ['0']*3
    prim = date[0].split()
    day, month = prim[1], months[prim[0]]
    new_date[0], new_date[1], new_date[2] = day, month, date[1].lstrip()
    print('/'.join(new_date))
