# encoding: utf-8

import os
import numpy as np
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression as lr

if __name__ == '__main__':
    plt.rcParams['font.family'] = 'YouYuan'
    plt.rcParams['font.size'] = 20
    files = os.listdir(".")
    # fig = plt.figure()
    for file in files:
        if '.txt' in file and 'test' in file:
            path = file
            data = np.genfromtxt(path)
            if '滚筒' in file:
                tp = 'r'
                fig = plt.figure(1)
                title = '滚筒实验后100g-700g线性度测试'
            elif '淋雨' in file:
                tp = 'y'
                fig = plt.figure(2)
                title = '淋雨实验后100g-700g线性度测试'
            else:
                tp = 'b'
                fig = plt.figure(3)
                title = '定向跌落实验后100g-700g线性度测试'
            fig.set_size_inches(60, 10)
            plt.plot(data[:, 0], data[:, 1], ''.join(('o', tp)))
            plt.text(data[-1, 0], data[-1, 1], file)
            linreg = lr()
            x = data[:, 0]
            y = data[:, 1]
            linreg.fit(x[:, np.newaxis], y[:, np.newaxis])
            print(linreg.intercept_, linreg.coef_[0])
            xx = np.array(range(1000))
            yy = linreg.coef_[0] * xx + linreg.intercept_
            plt.plot(xx, yy, ''.join(('--', tp)))
            plt.text(xx[-1], yy[-1], ''.join(
                ('%.2f,    %.2f' % (linreg.intercept_[0], linreg.coef_[0]))))

            plt.title(title, fontsize=20)
            plt.plot([0, 0], 'ko')
            plt.xlabel('testing weight: (g)', fontsize=20)
            plt.ylabel('output signal: (g)', fontsize=20)
            # plt.text(0, 60, 'half-graphite flake', color='b', fontsize=20)
            # plt.text(0, 70, 'none-graphite flake', color='y', fontsize=20)
            # plt.text(0, 80, 'graphite flake with hole', color='r', fontsize=20)
            # plt.text(0, 90, 'zero', color='k', fontsize=20)
            plt.grid()
            plt.savefig(''.join(('No_', file[:4], title, '.png')))
            plt.show()
