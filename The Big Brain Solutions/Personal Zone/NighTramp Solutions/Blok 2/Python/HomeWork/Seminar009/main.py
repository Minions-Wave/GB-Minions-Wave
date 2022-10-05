from telegram import Bot
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters


bot = Bot(token='5593423447:AAEe0rCZnZdYXNpxxyatR37l6afSppj-yZI')
updater = Updater(token='5593423447:AAEe0rCZnZdYXNpxxyatR37l6afSppj-yZI')
dispatcher = updater.dispatcher

def start(update, context):
    context.bot.send_message(update.effective_chat.id, 'Добро пожаловать')

def command(update, context):
    context.bot.send_message(update.effective_chat.id, 'Я таких команд не знаю')

def delete_words(update, context):
    context.bot.send_message(update.effective_chat.id, 'Обрабатываю...')
    words = context.args
    words = [word for word in words if not "а" in word]
    words = [word for word in words if not "б" in word]
    words = [word for word in words if not "в" in word]
    answer = " ".join(words)
    context.bot.send_message(update.effective_chat.id, f'Готово.\n"{answer}"')



start_handler = CommandHandler('start', start)
pars_handler = CommandHandler('pars', delete_words)

command_handler = MessageHandler(Filters.command, command)

dispatcher.add_handler(start_handler)
dispatcher.add_handler(pars_handler)

dispatcher.add_handler(command_handler)

updater.start_polling()
updater.idle()
