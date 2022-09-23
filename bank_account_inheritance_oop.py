from decimal import Decimal
class Account():
    def __init__(self,name,surname,balance=0):
        if balance < Decimal('0.0'):
            raise ValueError("Balance can not be less than 0")
        self._name = name
        self._surname = surname
        self._balance = balance

    @property
    def name(self):
        return self._name

    @property
    def surname(self):
        return self._surname

    @property
    def balance(self):
        return self._balance

    @balance.setter
    def balance(self,balance):
        if not (balance > Decimal('0.0')):
            raise ValueError("Balance cannot be less than 0")
        self._balance = balance

    def __repr__(self):
        return f"Name: {self._name}\n" \
               f"Surname: {self._surname}\n" \
               f"Balance: {self._balance}"

    def depositMoney(self,amount):
        if not amount > Decimal('0.0'):
            raise ValueError('The deposit cannot be less than 0')
        self._balance += amount
        return self._balance

    def withdrawMoney(self,amount):
        if not amount < self._balance:
            raise ValueError('The withdraw cannot be more than balance')
        self._balance -= amount
        return self._balance

class VadeliHesap(Account):
    def __init__(self,name,surname,ratio,balance=0):
        super().__init__(name,surname,balance)
        if not Decimal('0.0') < ratio <= 1:
            raise ValueError('Ratio must be between 0 and 1')
        self._ratio = ratio

    @property
    def ratio(self):
        return self._ratio

    @ratio.setter
    def ratio(self,ratio):
        if not Decimal('0.0') < ratio <= Decimal('1.0'):
            raise ValueError('Ratio must be between 0 and 1')
        self._ratio = ratio

    #Override
    def __repr__(self):
        return f"Vadeli Hesap\n------------\n" + super().__repr__() + f"\nRatio: {self._ratio:.2f}\n------------"

    def faizHesapla(self):
        self._balance += self._ratio * self._balance
        print(f"New Balance: {self._balance}")
        return Decimal(self.balance)

class VadesizHesap(Account):
    def __init__(self,name,surname,balance=0):
        super().__init__(name,surname,balance)
        self._fee = Decimal('0.0')

    @property
    def fee(self):
        return self._fee

    #Override
    def withdrawMoney(self,amount):
        self._fee = amount / 20  # %5 Fee
        self._balance = super().withdrawMoney(amount) - self._fee
        if not (self._balance > 0):
            raise ValueError('Balance cannot be less than 0')
        return self._balance

    def depositMoney(self,amount):
        self._fee = amount / 20 # %5 Fee
        self._balance = super().depositMoney(amount) - self._fee
        return self._balance

    def __repr__(self):
        return f"Vadesiz Hesap\n------------\n" + super().__repr__() + f"\nTransaction fee: {self._fee:.2f}\n------------"

a = Account("Dursun","Ipek",5000)
b = VadeliHesap("Dursun","İpek",balance=5000,ratio=0.15)
c = VadesizHesap("Dursun","İpek",balance=5000)

c.depositMoney(500)
print(c)
c.withdrawMoney(1100)
c.depositMoney(5000)
print(c)
c.withdrawMoney(9060)
print(c)