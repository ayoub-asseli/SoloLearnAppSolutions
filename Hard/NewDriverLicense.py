my_name, agents, other_names = input(), int(input()), input().split()
all_names = other_names + [my_name]
all_names.sort()
waiting_time = 20
for i in range(0, len(all_names), agents):
    if all_names[i] == my_name:
        break
    elif my_name in all_names[:i+agents]:
        break
    else:
        waiting_time += 20
print(waiting_time)