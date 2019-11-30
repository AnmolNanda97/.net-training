def wallet():
    balance = 0

    def deposit(amount):
        nonlocal balance
        i = int(input("Give some amount:"))
        print(i)
        balance += amount
        print("Amount available :", balance)

    def withdraw(cash):
        nonlocal balance
        if cash > balance:
            print("Amount exceeds available Limit")
        else:
            balance -= cash
            print("Amount Withdrawn :", cash)
            print("Amount available :", balance)

    def showbal():
        nonlocal balance
        print("Available Balance :", balance)

    return {"deposit": deposit, "withdraw": withdraw, "showbal": showbal}


def fundtransfer(b, trans, b2):
    b["withdraw"](trans)
    b2["deposit"](trans)
    b["showbal"]()
    b2["showbal"]()


bank = wallet()
bank2 = wallet()
bank["deposit"](100)
bank["deposit"](1000)
bank["withdraw"](10)
bank["showbal"]()

bank2["showbal"]()
fundtransfer(bank, 100, bank2)