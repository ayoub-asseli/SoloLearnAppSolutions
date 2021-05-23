message_encoded = list(input())
message_decoded = []
for elem in message_encoded:
    if elem not in "0123456789/:.;,?*+=%!)(-_€$*'&#@^¨<>`":
        message_decoded.append(elem)
print(''.join(message_decoded[::-1]))