require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

order = EasyPost::Order.retrieve('order_...')

order.buy(carrier: 'FedEx', service: 'FEDEX_GROUND')

puts order
