import random

INITIAL_SHIFT = 3
SECONDARY_SHIFT = INITIAL_SHIFT + 4
POSITION_DIVIDER = 5
FILE_NAME = "passwords.txt"

def main():
    check_user = input("Please enter your password: ")

    if check_user == "":
        is_done = "yes"
        while is_done == "yes":
            try:
                user_action = ""
                while user_action != "create" and user_action != "decrypt" and user_action != "encrypt":
                    user_action = input("Would you like to encrypt, decrypt, create, or quit: ").lower()
                    match user_action:
                        case "create":
                            create_password()
                            break
                        case "encrypt":
                            encrypt()
                            break
                        case "decrypt":
                            decrypt()
                            break
                        case "quit":
                            is_done = "no"
                            break
                        case _:
                            print("Not a valid option")
                            break
            except(EOFError, ValueError, KeyboardInterrupt, RuntimeError) as error:
                print(f"Error, Something Went Wrong, Please Try Again")
                print(error)
    else:
        print("Your Password doesn't match, Please try again: ")
            
        

def create_password():
    does_work = False
    while not does_work:
        try:
            password_place = input("What is this password to (ex. Facebook, Nintendo, etc.) ").capitalize()
            for i in password_place:
                if i == ":":
                    raise UnboundLocalError
            user_name = input("What is the Username for this password ")
            password_length = 31
            while password_length > 30 or password_length < 8:
                try:
                    password_length = int(input("How many characters can the password have? 8-30 "))
                    if password_length > 30 or password_length < 8:
                        raise ValueError
                    else:
                        password = password_creator(password_length)
                        first_encryption = encrypt_password(password, 0)
                        first_half, second_half = split_password(first_encryption)
                        salt = add_salt(password)
                        salt2 = add_salt(password)
                        salt3 = add_salt(password)
                        salted_password = create_salted_password(salt, salt2, salt3, first_half, second_half)
                        encrypted_password = encrypt_password(salted_password, 1)


                        write_to_file(password_place, encrypted_password, user_name)

                        print()
                        print(f"-------Username: {user_name} -------\n-------Password: {password} -------")
                        print(F"-------Encrypted Password: {encrypted_password} -------")
                        print()
                        does_work = True

                    
                except ValueError as ve:
                    print(f"Invalid Input")
                except(EOFError, KeyboardInterrupt) as error:
                    print(f"Error, Something Went Wrong, Please Try Again")
                    print(error)
        except UnboundLocalError as ULE:
            print("Invalid Input Error: ':' in the password")
        except(EOFError, ValueError, KeyboardInterrupt) as error:
            print(f"Error, Something Went Wrong, Please Try Again")
            print(error)
       

def encrypt():
    does_work = False
    while not does_work:
        try:
            password_place = input("What is this password to (ex. Facebook, Nintendo, etc.) ").capitalize()
            for i in password_place:
                if i == ":":
                    raise UnboundLocalError
            user_name = input("What is the Username for this password ")
            password = input("Please input the password you would like to encrypt: ")
            password_length = len(password)
            if password_length > 30 or password_length < 8:
                raise ValueError
            
            first_encryption = encrypt_password(password, 0)

            first_half, second_half = split_password(first_encryption)

            salt = add_salt(password)
            salt2 = add_salt(password)
            salt3 = add_salt(password)

            salted_password = create_salted_password(salt, salt2, salt3, first_half, second_half)

            encrypted_password = encrypt_password(salted_password, 1)

            write_to_file(password_place, encrypted_password, user_name)

            print()
            print(f"-------Username: {user_name} -------\n-------Password: {password} -------")
            print(F"-------Encrypted Password: {encrypted_password} -------")
            print()

            does_work = True
        except UnboundLocalError as ULE:
            print("Invalid Input Error: ':' in the password")
        except(EOFError, ValueError, KeyboardInterrupt) as error:
            print(f"Error, Something Went Wrong, Please Try Again")
            print(error)

def decrypt():
    does_work = False
    while not does_work:
        try:

            password_place = input("What is this password to (ex. Facebook, Nintendo, etc.) ").capitalize()

            encrypted_password, user_name = read_from_file(password_place)
            
            decrypted_password = decrypt_password(encrypted_password, 0)
            
            desalted_password = remove_salt(decrypted_password)
            
            second_decryption = decrypt_password(desalted_password, 1)

            print()
            print(f"-------Username: {user_name} -------")
            print(f"-------Decrypted Password: {second_decryption} -------")
            print()
            does_work = True
        except UnboundLocalError as ULE:
            print("Invalid Input Error: Could Not Find Password")
            print(ULE)
        except(EOFError, ValueError, KeyboardInterrupt) as error:
            print(f"Error, Something Went Wrong, Please Try Again")
            print(error)

def password_creator(password_length):
    # randomly chooses characters from these list, randomly
    letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
           'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
           'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
           'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
    numbers = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
    special_characters = ['!', '#', '$', '%', '&', '(', ')', '*', '+', 
                             '-', '.', '/', ':', ';', '<', '=', '>', '?', '@',
                            '[', ']', '_', '{', '|', '}', '~']
    password = ""
    while len(password) < password_length:
        character_picker = random.randint(1,10) # makes it so that the ratio between letters and numbers vs special characters is bigger.
        if character_picker <= 6:
            character = random.choice(letters)
        elif character_picker == 7 or character_picker == 8:
            character = random.choice(numbers)
        elif character_picker == 9 or character_picker == 10:
            character = random.choice(special_characters)
        password = password + character
    return password

def split_password(password):
    halved_length = len(password) // 2
    first_half = password[:halved_length]
    second_half = password[halved_length:]
    return first_half, second_half

def add_salt(password): # adds salt or extra characters to the beginning of the password
    letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
           'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
           'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
           'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
    numbers = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
    special_characters = ['!', '#', '$', '%', '&', '(', ')', '*', '+', 
                             '-', '.', '/', ':', ';', '<', '=', '>', '?', '@',
                            '[', ']', '_', '{', '|', '}', '~']
    number_of_characters = int(len(password) / 2) # bases the number of salt characters added by the password number divided by 3
    salt = ""
    while number_of_characters != 0:
        character_picker = random.randint(1,10)
        if character_picker <= 6:
            character = random.choice(letters)
        elif character_picker == 7 or character_picker == 8:
            character = random.choice(numbers)
        elif character_picker == 9 or character_picker == 10:
            character = random.choice(special_characters)
        salt = character + salt
        number_of_characters -= 1
    return salt

def create_salted_password(salt, salt2, salt3, first_half, second_half):
    rand_number = random.randint(1,5)
    if rand_number == 1:
        return f"{salt},{first_half},{salt2},{second_half},{salt3},1"
    elif rand_number == 2:
        return f"{salt},{second_half},{salt2},{first_half},{salt3},2"
    elif rand_number == 3:
        return f"{salt3},{salt2},{first_half},{salt},{second_half},3"
    elif rand_number == 4:
        return f"{second_half},{salt2},{salt3},{salt},{first_half},4"
    elif rand_number == 5:
        return f"{first_half},{salt},{salt2},{second_half},{salt3},5"

def remove_salt(salted_password):
    """original_string = "Hello World"
    trimmed_string = original_string[5:]
    print(trimmed_string)  Output: ' World' """
    desalted_password = salted_password.strip().split(",")
    salt_key = desalted_password[-1]
    if salt_key == "1":
        return f"{desalted_password[1]}{desalted_password[3]}"
    elif salt_key == "2":
        return f"{desalted_password[3]}{desalted_password[1]}"
    elif salt_key == "3":
        return f"{desalted_password[2]}{desalted_password[4]}"
    elif salt_key == "4":
        return f"{desalted_password[4]}{desalted_password[0]}"
    elif salt_key == "5":
        return f"{desalted_password[0]}{desalted_password[3]}"

def encrypt_password(salted_password, count):

    if count == 0:
        char_set = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:.<>?/~"
    elif count == 1:
        char_set = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:,.<>?/~"
    char_set_length = len(char_set)
    encrypted_password = ""
    current_shift = INITIAL_SHIFT
    secondary_current_shift = SECONDARY_SHIFT
    position = len(salted_password) / POSITION_DIVIDER

    for i, char in enumerate(salted_password):
        if char in char_set:
            if (i + 1) % position == 0:
                shift_amount = secondary_current_shift
                secondary_current_shift += 3
            else:
                shift_amount = current_shift
            char_index = char_set.find(char)
            shifted_index = (char_index + shift_amount) % char_set_length
            encrypted_password += char_set[shifted_index]
            current_shift += 1
        else:
            encrypted_password += char
    return encrypted_password

def decrypt_password(encrypted_password, count):
    if count == 1:
        char_set = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:.<>?/~"
    elif count == 0:
        char_set = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:,.<>?/~"
    char_set_length = len(char_set)
    decrypted_password = ""
    current_shift = INITIAL_SHIFT
    secondary_current_shift = SECONDARY_SHIFT
    position = len(encrypted_password) / POSITION_DIVIDER

    for i, char in enumerate(encrypted_password):
        if char in char_set:
            if (i + 1) % position == 0:
                shift_amount = -secondary_current_shift
                secondary_current_shift += 3
            else:
                shift_amount = -current_shift
            char_index = char_set.find(char)
            shifted_index = (char_index + shift_amount) % char_set_length
            decrypted_password += char_set[shifted_index]
            current_shift += 1
        else:
            decrypted_password += char
    return decrypted_password

def write_to_file(password_place, encrypted_password, user_name):
    password_found = False
    with open(FILE_NAME, "r") as file:
        for line in file:
            parts = line.strip().split(":", 2)
            place_of_password = parts[0]
            if place_of_password == password_place:
                password_found = True
        if password_found == False:
            with open(FILE_NAME, "a") as file:
                file.write(f"{password_place}: {user_name}: {encrypted_password}\n")
        else:
            change_password(password_place, encrypted_password, user_name)

def change_password(password_place, encrypted_password, user_name):
    updated_lines = []  
    with open(FILE_NAME, "r") as file:
        for line in file:
            parts = line.strip().split(":", 2)
            place_of_password = parts[0]
            if place_of_password == password_place:
                updated_lines.append(f"{password_place}: {user_name}: {encrypted_password}\n")
            else:
                updated_lines.append(line)
    with open(FILE_NAME, 'w') as file:
        file.writelines(updated_lines)

def read_from_file(password_place):
    with open(FILE_NAME, "rt") as file:
        for line in file:
            parts = line.split(":", 2)
            place_of_password = parts[0]
            if place_of_password == password_place:
                user_name = parts[1].strip()
                encrypted_password = parts[2]
                # print(len(encrypted_password))
            else:
                pass
        return encrypted_password, user_name

if __name__ == "__main__":

    main()





"""
PasswordManager: This class will handle the main functionality of the program, including user interaction and managing the flow of the program.

Password: This class will represent a password, including its plaintext and encrypted forms.

User: This class will represent a user, including their username and associated passwords.

FileManager: This class will handle reading from and writing to the file where passwords are stored.

EncryptionService: This class will handle the encryption and decryption of passwords.

SaltService: This class will handle adding and removing salt from passwords.

PasswordGenerator: This class will handle the creation of random passwords.

InputValidator: This class will handle validating user input.
"""