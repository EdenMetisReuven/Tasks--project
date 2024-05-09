def polyndrom(word: str) -> bool:
    if is_sorted_polyndrom(word) is True:
        for i in range (len(word)//2):
            if word[i] != word[len(word) -1 - i]:
                return False
        return True
    else:
        return False
def is_sorted_polyndrom (word: str) -> bool:
    # char_list = []
    # for i in range (len(word)):
    #     char_list[i]=word[i]
    for i in range((len(word)//2)-1):
        if word[i] > word[i+1] and word[len(word) -1 - i] > word[(len(word)//2) + i]:
            return False
    return True

print (polyndrom("1221"))

