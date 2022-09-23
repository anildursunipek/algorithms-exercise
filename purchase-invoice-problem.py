item_list = ['Laptop','Headset','Second Monitor','Mousepad','USB Driver','External Drive']
cart = []
price_sheet = {
    "Laptop" : 1500,
    "Headset" : 100,
    "Second Monitor" : 200,
    "Mousepad" : 50,
    "USB Driver" : 70,
    "External Drive" : 250
}
limit_budget = 5000

def add_to_cart(item,quantity):
    cart.append((item,quantity))
    item_list.remove(item)

def create_invoice():
    total_amount_inc_tax = 0
    for item,quantity in cart:
        price = price_sheet[item]
        tax = 0.18 * price
        total = (tax + price) * quantity
        total_amount_inc_tax += total
        print('Item: ', item , '\t' , 'Price: ' , price , '\t' , 'Quantity' , quantity , '\t' , 'Tax: ', tax , '\t', 'Total: ', total ,)

    print('Total amount include tax: ' , total_amount_inc_tax)
    return total_amount_inc_tax

def checkout():
    global limit_budget
    total_amount = create_invoice()
    if limit_budget == 0:
        print('You dont have any budget')
    elif total_amount > limit_budget:
        print('The amount you have to pay is above the spending limit. You have to drop some items')
    else:
        limit_budget -= total_amount
        print(f"The total amount (inc. taxes) you've paid is {total_amount:.2f}. You have {limit_budget:.2f} dollars left")

# Add items to cart
add_to_cart("Laptop",1)
add_to_cart("Headset",5)
add_to_cart("Second Monitor",1)
add_to_cart("Mousepad",1)
add_to_cart("USB Driver",2)
add_to_cart("External Drive",4)

checkout()



