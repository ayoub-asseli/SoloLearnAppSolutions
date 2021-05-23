hours = {
    '1': '13',
    '2': '14',
    '3': '15',
    '4': '16',
    '5': '17',
    '6': '18',
    '7': '19',
    '8': '20',
    '9': '21',
    '10': '22',
    '11': '23',
    '12': '00'
}
string = input().split(':')
if string[0] != '12':
    if 'PM' in string[1]:
        string[0] = hours[string[0]]
        print(':'.join(string).replace('PM', ''))
    else:
        if len(string[0]) < 2:
            print('0' + ':'.join(string).replace('AM', ''))
        else:
            print(':'.join(string).replace('AM', ''))
else:
    if 'AM' in string[1]:
        string[0] = hours[string[0]]
        if len(string[0]) < 2:
            print('0' + ':'.join(string).replace('AM', ''))
        else:
            print('0' + ':'.join(string).replace('AM', ''))
    else:
        print(':'.join(string).replace('PM', ''))