#ifndef CARTYPES_H_INCLUDED
#define CARTYPES_H_INCLUDED

typedef enum {VOLVO, TOYOTA, LAND_ROVER, TESLA} car_type;

typedef struct {
    car_type type;
	double km;
	double gas;
}car;


#endif // CARTYPES_H_INCLUDED
