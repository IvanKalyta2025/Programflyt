
The app's purpose is to show an employee's mental state. To do this, employees can select their mood on a scale from 1 to 10.

This way, we'll be able to monitor the mood trends of our employees.

If we receive a response from an employee and determine their mood, we offer them a choice of an item,
 which, in the next step, will increase the employee's rating by several points.


PROGRAM MoodEvaluator

GLOBAL VARIABLE:
    inputNumber (integer)

MAIN FUNCTION:
    LOOP FOREVER:
        PRINT "Rate your mood from 1 to 10: "
        input READ LINE

        IF input is not a number THEN
            PRINT "Please enter a valid number."
            CONTINUE LOOP
        END IF

        inputNumber  CONVERT input TO integer

        IF inputNumber < 1 OR inputNumber > 10 THEN
            PRINT "Please choose a number between 1 and 10."
            CONTINUE LOOP
        END IF

        service  NEW Service(inputNumber)

        // Main mood check logic
        IF service.InputNumber <= 0 THEN
            PRINT "You scare us... what happened?"
            WAIT 5 seconds
        ELSE IF service.InputNumber <= 5 THEN
            PRINT "Seems like you’re not in the mood. Go grab some pie"
            WAIT 5 seconds
        ELSE IF service.InputNumber <= 10 THEN
            PRINT "Nice! You're in a great mood — let's give you extra tasks"
            WAIT 5 seconds
        ELSE
            PRINT "The number must be between 1 and 10."
        END IF

        // Call the Gift system (based on your number)
        CALL GiftController.Gift()

        // Exit after valid input and gift
        BREAK LOOP
    END LOOP
END FUNCTION


// ---------------------------
// CLASS: Service
// ---------------------------
CLASS Service
    PROPERTY InputNumber (integer)

    CONSTRUCTOR Service(value):
        // Make sure number stays within 0–10 range
        InputNumber CLAMP(value, 0, 10)
    END CONSTRUCTOR
END CLASS


// ---------------------------
// CLASS: GiftController
// ---------------------------
CLASS GiftController
    CLASS GiftClass
        STATIC FUNCTION Gift():
            number  Program.inputNumber
            service  NEW Service(number)

            IF service.InputNumber <= 0 THEN
                PRINT "You look miserable... we’re firing you"
            ELSE IF service.InputNumber <= 5 THEN
                PRINT "Here’s a pie, take a break"
            ELSE IF service.InputNumber <= 10 THEN
                PRINT "You’re too cheerful — here’s some extra work "
            END IF
        END FUNCTION
    END CLASS
END CLASS
