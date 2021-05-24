noises = input().split()
for noise in noises:
    if noise == 'Grr':
        print('Lion', end=' ')
    elif noise == 'Rawr':
        print('Tiger', end=' ')
    elif noise == 'Ssss':
        print('Snake', end=' ')
    else:
        print('Bird', end=' ')