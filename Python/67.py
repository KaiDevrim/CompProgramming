a = "1"
b = "111"
first = int(a)
second = int(b)
result = 0
carry = False

if len(a) < len(b):
    a = a.zfill((len(b) - len(a)) + 1)
    result = result.zfill(len(a))
if len(b) < len(a):
    b = b.zfill((len(a) - len(b)) + 1)
    result = result.zfill(len(b))

for bit in a:
    aBit = int(reversed(a[bit]))
    bBit = int(reversed(b[bit]))
    if (aBit & bBit) == 0:
        carry = True
        result[bit] = 0
    elif carry:
        if ()

print(a + "\n" + b)
