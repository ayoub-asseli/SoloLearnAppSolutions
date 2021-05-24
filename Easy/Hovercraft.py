building_cost, selling_cost, insurance_cost = 2000000, 3000000, 1000000
sales = int(input())
if (building_cost*10 + insurance_cost) < sales*selling_cost:
    print('Profit')
elif (building_cost*10 + insurance_cost) > sales*selling_cost:
    print('Loss')
else:
    print('Broke Even')