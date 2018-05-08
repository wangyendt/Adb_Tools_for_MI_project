# encoding: utf-8

import numpy as np
import matplotlib.pyplot as plt
import os
import sys

if __name__ == '__main__':
    files = os.listdir(sys.argv[1])
    for f in files:
        if 'rawData' in f and 'txt' in f:
            data = np.genfromtxt(''.join((sys.argv[1], '/', f)))
            plt.figure()
            plt.plot(data[:,0])
            plt.show()
