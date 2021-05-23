text = input()
for e in text:
    if e in "/:.;,?*+=%!)(-_€$*'&#@^¨<>`":
        text = text.replace(e, '')
print(text)