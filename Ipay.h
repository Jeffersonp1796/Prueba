// ipay.h

#ifndef IPAY_H
#define IPAY_H

typedef struct {
    double (*ValueToPay)(void);
} IPay;

void initIPay(IPay* iface);

#endif // IPAY_H
