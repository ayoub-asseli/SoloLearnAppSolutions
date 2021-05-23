words = input().split()
new_words = []
for word in words:
    word = word[1:] + word[0] + 'ay'
    new_words.append(word)
print(' '.join(new_words))