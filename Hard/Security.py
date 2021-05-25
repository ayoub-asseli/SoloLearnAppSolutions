floor_layout = input().replace('x', '')
for i in range(len(floor_layout)):
    if floor_layout[i] == '$':
        if 'TG' in floor_layout[i+1:]:
            print('ALARM')
            exit()
        elif 'G' not in floor_layout[i+1:] and 'T' in floor_layout[i+1:]:
            print('ALARM')
    elif floor_layout[i] == 'T':
        if '$G' in floor_layout[i+1:]:
            print('ALARM')
            exit()
        elif 'G' not in floor_layout[i+1:] and '$' in floor_layout[i+1:]:
            print('ALARM')
            exit()
print('quiet')