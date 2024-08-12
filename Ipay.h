// ipay.h

#ifndef IPAY_H
#define IPAY_H

// Definición de la interfaz IPay
typedef struct {
    double (*ValueToPay)(void);  // Puntero a función que devuelve el valor a pagar
} IPay;

// Función para inicializar la interfaz IPay
void initIPay(IPay* iface);

#endif // IPAY_H
