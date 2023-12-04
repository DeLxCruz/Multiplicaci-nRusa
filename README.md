# Multiplicación Rusa

Este programa implementa el algoritmo de la multiplicación rusa para multiplicar dos números enteros.

## Enunciado

El método de multiplicación rusa consiste en multiplicar sucesivamente por 2 el multiplicando y
dividir por 2 el multiplicador hasta que el multiplicador tome el valor 1.
Luego, se suman todos los multiplicandos correspondientes a los multiplicadores impares.
Dicha suma es el producto de los dos números. La siguiente tabla muestra el cálculo realizado para
multiplicar 37 por 12, cuyo resultado final es 12 + 48 + 384 = 444.

Desarrolle un programa que reciba como entrada el multiplicador y el multiplicando, y entregue
como resultado el producto de ambos, calculado mediante el método de multiplicación rusa.

## Cómo funciona

1. El programa solicita al usuario que ingrese dos números: el multiplicador y el multiplicando.
2. Luego, el programa entra en un bucle `while` que continúa mientras el multiplicador sea mayor o igual a 1.
3. Dentro del bucle, si el multiplicador es impar (es decir, el resto de la división por 2 es diferente de 0), se suma el multiplicando al resultado.
4. Luego, el multiplicador se divide por 2 (ignorando cualquier resto) y el multiplicando se multiplica por 2.
5. Este proceso se repite hasta que el multiplicador es menor que 1.
6. Finalmente, el programa muestra el resultado de la multiplicación.

## Ejecución

Para ejecutar el programa, simplemente compílelo y ejecútelo en su entorno de desarrollo integrado (IDE) de C#. El programa solicitará que ingrese los dos números a multiplicar y luego mostrará el resultado.

## Nota

Este algoritmo es una forma eficiente de multiplicar dos números, especialmente cuando uno de ellos es grande. Sin embargo, tenga en cuenta que este programa no maneja errores de entrada, por lo que asegúrese de ingresar solo números enteros.
