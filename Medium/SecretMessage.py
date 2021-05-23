alpha = [chr(i) for i in range(ord('a'), ord('z')+1)]
inv_alpha = alpha[::-1]
letters = list(zip(alpha,inv_alpha))
string, new_string = input().lower(), ''
for letter in string:
    if letter == ' ':
        new_string += ' '
        continue
    for i in range(len(letters)):
        if letter == letters[i][0]:
            new_string += letters[i][1]
print(new_string)