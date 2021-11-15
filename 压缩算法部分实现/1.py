from numpy import array, float32, floor
from numpy.random.mtrand import randint

dct = randint(0, 128, (8, 8))
print("DCT: ")
print(dct)
brightness_scale = array(([16, 11, 10, 16, 24, 40, 51, 61],
                          [12, 12, 14, 19, 26, 58, 60, 55],
                          [14, 13, 16, 24, 40, 57, 69, 56],
                          [14, 17, 22, 29, 51, 87, 80, 62],
                          [18, 22, 37, 56, 68, 109, 103, 77],
                          [24, 35, 55, 64, 81, 104, 113, 92],
                          [49, 64, 78, 87, 103, 121, 120, 101],
                          [72, 92, 95, 98, 112, 100, 103, 99]), dtype=float32)
quantify = floor(array(dct / brightness_scale + 0.50, dtype=float32))
print("quantify: ")
print(quantify)
z = list()
i = j = 0

for x in range(8):
    for y in range(8):
        z.append(int(quantify[i, j]))
        if(j % 2. == 0 and (i == 0 or i == 7)):
            j += 1
        elif(i % 2. != 0 and (j == 0 or j == 7)):
            i += 1
        elif((i+j) % 2. == 0):
            i -= 1
            j += 1
        elif((i+j) % 2. != 0):
            i += 1
            j -= 1

print("z: ")
print(z)
trip_code = ""
count = 0
buffer = ""

for i in range(64):
    if(z[i] == 0):
        count += 1
    else:
        buffer = bin(count)[2:]
        while(len(buffer) < 4):
            buffer = "0" + buffer
        if(count > 15):
            trip_code += "F0H"
            count = 0
            continue
        trip_code += buffer
        buffer = bin(len(bin(z[i])[2:]))[2:]
        while(len(buffer) < 4):
            buffer = "0" + buffer
        trip_code += buffer
        trip_code += bin(z[i])[2:]
        count = 0
trip_code += "00H"

print("trip_code: ")
print(trip_code)
