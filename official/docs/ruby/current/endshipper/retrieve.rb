require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

endshipper = EasyPost::EndShipper.retrieve('es_...')

puts endshipper
